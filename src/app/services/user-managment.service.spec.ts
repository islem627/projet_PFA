import { TestBed } from '@angular/core/testing';
import { userManagementService } from './user-managment.service';

describe('UserManagmentService', () => {
  let service: userManagementService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(userManagementService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
