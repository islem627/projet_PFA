export class User {
  id: number = 0;  // Initialize with a default value
   email: string;
  password: string;
  type: string[];

  constructor() {
    this.id = 0;  // Initialize id to 0
    this.email = '';
    this.password = '';
    this.type = [];
  }
}
