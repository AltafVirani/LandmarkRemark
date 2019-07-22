import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class LocationMarkerService {
  private headers: HttpHeaders;
  private LocationMarkersUrl: string = 'api/LocationMarkers';

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
  }

   
  public get() {
    // Get all Location markers data from server
    return this.http.get(this.baseUrl+ this.LocationMarkersUrl, { headers: this.headers });
  }

  //Add Location marker data to server
  public add(payload) {
    return this.http.post(this.baseUrl + this.LocationMarkersUrl, payload, { headers: this.headers });
  }

}
