
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LocationMarkerService } from '../location-marker.service'
import { LocationMarker } from '../models/location-marker'
import { FilterPipe } from '../pipes/filterpipe'
import { DataService } from '../data.service'

@Component({
  selector: 'location-map',
  templateUrl: './location-map.component.html',
  styleUrls: ['./location-map.component.css']
})
export class LocationMapComponent {
  title: string = 'Location Maps';
  lat: number;
  lng: number;

  locations: LocationMarker[] = [
  ];

  searchToken: string;

  constructor(private locMarkerService: LocationMarkerService, private dataService: DataService) {
    if (navigator) {
      navigator.geolocation.getCurrentPosition(pos => {
        this.lng = +pos.coords.longitude;
        this.lat = +pos.coords.latitude;

      
      });
    }    
       
    this.GetLocations();
  } 

  GetLocations() {
    this.locMarkerService.get().subscribe((result: LocationMarker[]) => {
      this.locations = result;
      this.locations = this.locations.map(loc => {
        var str = loc.userName;
        loc.label = {
          text: str.substr(0, 1)//,
        };
        return loc;
      });
    
    }, error => console.error(error));
  }
  OnChoseLocation(event) {
   
     this.locations.push(
         {
           title: "title",
           lat: event.coords.lat,
           lng: event.coords.lng,
         comment: "test",
         userID: this.dataService.user.userID,
         userName: this.dataService.user.userName        
         }
       );
    
    this.locMarkerService.add(
      {
        title: "title",
        lat: event.coords.lat,
        lng: event.coords.lng,
        userID: this.dataService.user.userID,
        comment: "test"
      }
    ).subscribe(
    
      (data: any[]) => {
        this.GetLocations();    
      }
    );
    
  }
}
