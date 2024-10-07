import { Component, OnInit } from '@angular/core';
import { TableModule } from 'primeng/table';
import { CommonModule } from '@angular/common';
import { User } from '../../Models/user.model'; 
import { ButtonModule } from 'primeng/button';
import { MessageService } from 'primeng/api'; 
import { UserManagementService } from '../../services/User-Management.service'; // Corrected import path
import { HttpErrorResponse } from '@angular/common/http'; // Import HttpErrorResponse for type safety

@Component({
  selector: 'app-usermanagment',
  standalone: true,
  imports: [TableModule, CommonModule, ButtonModule],
  templateUrl: './UserManagement.component.html',
  styleUrls: ['./UserManagement.component.css'], // Corrected to 'styleUrls'
  providers: [UserManagementService, MessageService]
})
export class UserManagementComponent implements OnInit {
  users: User[] = [];
  selectedUser: User = { id: 0, email: '', password: '', type: [] };

  constructor(
    private userManagementService: UserManagementService,  // Corrected variable name
    private messageService: MessageService
  ) {}

  ngOnInit(): void {
    this.fetchUsers();
  }

  fetchUsers(): void {
    this.userManagementService.getUsers().subscribe(
      (data: User[]) => {
        this.users = data;
      },
      (error: HttpErrorResponse) => {  // Explicitly typed error as HttpErrorResponse
        console.error('Error fetching users', error);
      }
    );
  }

  submitUser(): void {
    this.userManagementService.addUser(this.selectedUser).subscribe(
      () => {
        this.messageService.add({ severity: 'success', summary: 'Success', detail: 'User added successfully' });
        this.fetchUsers();
      },
      (error: HttpErrorResponse) => {  // Explicitly typed error as HttpErrorResponse
        console.error('Error adding user', error);
      }
    );
  }

  updateUser(): void {
    this.userManagementService.updateUser(this.selectedUser).subscribe(
      () => {
        this.messageService.add({ severity: 'success', summary: 'Success', detail: 'User updated successfully' });
        this.fetchUsers();
      },
      (error: HttpErrorResponse) => {  // Explicitly typed error as HttpErrorResponse
        console.error('Error updating user', error);
      }
    );
  }

  deleteUser(id: number): void {
    this.userManagementService.deleteUser(id).subscribe(
      () => {
        this.messageService.add({ severity: 'success', summary: 'Success', detail: 'User deleted successfully' });
        this.fetchUsers();
      },
      (error: HttpErrorResponse) => {  // Explicitly typed error as HttpErrorResponse
        console.error('Error deleting user', error);
      }
    );
  }
}
