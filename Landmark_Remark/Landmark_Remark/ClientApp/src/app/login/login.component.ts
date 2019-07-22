import { Component, Inject } from '@angular/core';
import { Router } from "@angular/router";
import { DataService } from '../data.service';
import { UserService } from '../user.service';
import { User } from '../models/user';

@Component({
  selector: 'login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  constructor(private router: Router, private userService: UserService, private dataService: DataService) {
    
  }

  public username: string;
  public password: string;
  public error: string;

  
  OnLogin(event) {
    
    this.userService.get(this.username, this.password).subscribe((result: User) => {
      this.dataService.user = result;
      console.log(this.dataService.user);
      this.router.navigate(['location-map']);
    }, error => {
      this.error = "Incorrect username or password.";
      console.error(error)
    }
      );

    
  }
   
}
