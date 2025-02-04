import { Component } from '@angular/core';
import { ButtonModule } from 'primeng/button';
import { AppMenuComponent } from './features/menu/menu.component';

@Component({
    selector: 'app-root',
    imports: [
        // RouterOutlet,

        /// App
        AppMenuComponent,

        /// Prime

        ButtonModule],
    templateUrl: './app.component.html',
    styleUrl: './app.component.scss'
})
export class AppComponent {

}
