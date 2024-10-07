import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';
import { importProvidersFrom } from '@angular/core';
import { AppRoutingModule } from './app/app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { TableModule } from 'primeng/table';

bootstrapApplication(AppComponent, {
  providers: [
    importProvidersFrom(AppRoutingModule, HttpClientModule, TableModule)
  ]
}).catch(err => console.error(err));
