

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AppComponent } from './app.component';
import { LocationMapComponent } from './location-map/location-map.component';
import { LoginComponent } from './login/login.component'

import { LocationMarkerService } from './location-marker.service'
import { DataService } from './data.service'
import { AgmCoreModule } from '@agm/core';
import { AgmSnazzyInfoWindowModule } from '@agm/snazzy-info-window';
import { FilterPipe } from './pipes/filterpipe'
import { UserService } from './user.service';

@NgModule({
  declarations: [
    AppComponent,  
    LocationMapComponent,
    LoginComponent,
    FilterPipe
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,    
    FormsModule,
    NgbModule,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyAYR0R4b-cM02qOyJy9Ix8gD4o3RC2TQfk'
    }),
    AgmSnazzyInfoWindowModule,
    RouterModule.forRoot([
      { path: '', component: LoginComponent, pathMatch: 'full' },
      { path: 'location-map', component: LocationMapComponent}
      
    ])
  ],
  providers: [LocationMarkerService, DataService, UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
