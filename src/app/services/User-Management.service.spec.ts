import { TestBed } from '@angular/core/testing';
import { UserManagementService } from './User-Management.service';

describe('UserManagmentService', () => {
  let service: UserManagementService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UserManagementService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
