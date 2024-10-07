import { Component ,  } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PrimeNGConfig } from 'primeng/api';
import { UserManagementComponent } from "./pages/admin/UserManagement.component";
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, UserManagementComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent  {
  title = 'mon-app';

   
}

