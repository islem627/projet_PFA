import { Component , OnInit } from '@angular/core';
import { TableModule } from 'primeng/table';
import { CommonModule } from '@angular/common';
import { userManagementService } from '../../services/user-managment.service';
import { User } from '../../Models/user.model'; 
import { ButtonModule } from 'primeng/button';



@Component({
  selector: 'app-usermanagment',
  standalone: true,
  imports: [TableModule, CommonModule,ButtonModule],
  templateUrl: './usermanagment.component.html',
  styleUrl: './usermanagment.component.css',
  providers: [userManagementService]
})

  

export class UserManagementComponent implements OnInit {
  users: User[] = [
    { id: 1, email: 'islemjeridi03@gmail.com', password: 'islem123',type: 'client' },
    { id: 2, email: 'linajeridi18@gmail.com', password: '123456',type:"livreur" },
    { id: 3, email: 'ahmedbenali10@gmail.com', password: 'ahmed147',type:"restaurant" }
  ];
  constructor(private userManagementService: userManagementService) {}

  ngOnInit(): void {
   /* this.fetchUsers();*/
  }

  fetchUsers(): void {
    this.userManagementService.getUsers().subscribe(
      (data: User[]) => { // Specify the type of data
        this.users = data; // Store users in the array
      },
      (error) => {
        console.error('Erreur lors de la récupération des utilisateurs', error);
      }
    );
  }
}