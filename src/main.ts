import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { AppComponent } from './app/app.component';
import { UsermanagmentComponent } from './app/pages/admin/usermanagment.component'; // Assurez-vous que le chemin est correct

/*import { environment } from 'src/environments/environment';
if (environment.production) {
  enableProdMode();
}*/
bootstrapApplication(UsermanagmentComponent)
  .catch(err => console.error(err));