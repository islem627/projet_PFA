import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {UserManagementComponent} from './pages/admin/UserManagement.component';
export const routes: Routes = [
  { path: 'admin', component: UserManagementComponent },
  { path: '', redirectTo: '/usermanagement', pathMatch: 'full' }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }




