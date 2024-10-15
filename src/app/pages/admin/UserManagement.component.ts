import { Component } from '@angular/core';
import { User } from '../../Models/user.model'; 
import { CommonModule } from '@angular/common';
import { MessageService } from 'primeng/api';
import { ButtonModule } from 'primeng/button';
import { DialogModule } from 'primeng/dialog';
import { TableModule } from 'primeng/table';
import { UserManagementService } from '../../services/User-Management.service';
import { FormsModule } from '@angular/forms';
import { DropdownModule } from 'primeng/dropdown';


@Component({
  selector: 'app-usermanagment',
  standalone: true,
  imports: [CommonModule,
    FormsModule,
    TableModule,
    ButtonModule,
    DialogModule,DropdownModule],
  templateUrl: './UserManagement.component.html',
  styleUrls: ['./UserManagement.component.css'],
  providers: [UserManagementService, MessageService]

})
export class UserManagementComponent {
  //table
  users: User[] = [
    { id: 1, email: 'artisant@example.com', password: '1234', type: ['Restaurant'] },
    { id: 2, email: 'livreur@example.com', password: '1234', type: ['Livreur'] },
    { id: 3, email: 'client@example.com', password: '1234', type: ['Client'] },
  ];
  userTypes: string[] = ['Client', 'Livreur', 'Restaurant'];
  selectedUser: User = { id: 0, email: '', password: '', type: [] };
  userDialog: boolean = false;
  constructor(private userManagementService: UserManagementService) {}
  ngOnInit() {
    this.userManagementService.getUsers().subscribe(users => {
      this.users = users;
    });
     //table
    this.initUsers(); 
  }
  
  openNew() {
    this.selectedUser = { id: 0, email: '', password: '', type: [] };
    this.userDialog = true;
  }
   //table
  initUsers() {
    const storedUsers = localStorage.getItem('users');
    if (storedUsers) {
      this.users = JSON.parse(storedUsers);
    } else {
      this.users = [
        { id: 1, email: 'artisant@example.com', password: '1234', type: ['Restaurant'] },
        { id: 2, email: 'livreur@example.com', password: '1234', type: ['Livreur'] },
        { id: 3, email: 'client@example.com', password: '1234', type: ['Client'] },
      ];
    }
  }
  editUser(user: User) {
     //table
    this.selectedUser = { ...user };
    this.userManagementService.updateUser(this.selectedUser).subscribe(() => {
    });
    this.userDialog = true;
  }

  saveUser() {
     //table
    if (this.selectedUser.id) {
      const index = this.users.findIndex(user => user.id === this.selectedUser.id);
      this.users[index] = this.selectedUser;
    } else {
      this.selectedUser.id = this.users.length + 1; 
      this.users.push(this.selectedUser);
    }
    this.userManagementService.addUser(this.selectedUser).subscribe(() => {
    });
     //table
    localStorage.setItem('users', JSON.stringify(this.users));
    this.userDialog = false; 
    this.userDialog = false; 
  }

  hideDialog() {
    this.userDialog = false;
  }

  deleteUser(id: number) {
    this.userManagementService.deleteUser(id).subscribe(() => {
    });
     //table
    this.users = this.users.filter(user => user.id !== id);
  }
}
