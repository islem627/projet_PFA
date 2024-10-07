import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { TableModule } from 'primeng/table';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  imports: [
    BrowserModule,
    AppRoutingModule,
    TableModule,
    HttpClientModule,
  ],
  providers: []
})
export class AppModule { }
