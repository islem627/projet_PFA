import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../Models/user.model';
import { UserUpdateDto } from '../Dtos/UserUpdate.Dto';




@Injectable({
  providedIn: 'root'
})
export class UserManagementService {
  private apiUrl = 'https://localhost:7255/api/UserManagement'; // Your backend URL

  constructor(private http: HttpClient) {}

  // Get all users
  getUsers(): Observable<User[]> {
    return this.http.get<User[]>(`${this.apiUrl}/adduser`);
  }

  // Get user by ID
  getUserById(id: number): Observable<User> {
    return this.http.get<User>(`${this.apiUrl}/${id}`);
  }

  // Add user
  addUser(user: User): Observable<any> {
    return this.http.post(`${this.apiUrl}`, user);
  }

  // Update user
  updateUser(user: UserUpdateDto): Observable<any> {
    return this.http.put(`${this.apiUrl}/updateuser/${user.id}`, user);
  }

  // Delete user
  deleteUser(id: number): Observable<any> {
    return this.http.delete(`${this.apiUrl}/deleteuser/${id}`);
  }
}