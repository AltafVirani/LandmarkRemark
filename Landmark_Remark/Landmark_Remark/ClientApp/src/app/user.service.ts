import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class UserService {
  private headers: HttpHeaders;
  private LocationMarkersUrl: string = 'api/LogIn';

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
  }

  // Verify username and password and get user from server
  public get(userName:string, password:string) {
    // Get all Location markers data
    return this.http.get(this.baseUrl + this.LocationMarkersUrl + '?userName=' + userName + '&password=' + password, { headers: this.headers });
  }

  

}
