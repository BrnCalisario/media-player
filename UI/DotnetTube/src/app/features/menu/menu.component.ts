import { Component } from '@angular/core';
import { MenuItem, PrimeIcons } from 'primeng/api';
import { ButtonModule } from 'primeng/button';
import { MenubarModule } from 'primeng/menubar';

@Component({
    selector: 'app-menu',
    imports: [
        MenubarModule,
        ButtonModule
    ],
    templateUrl: './menu.component.html',
    styleUrl: './menu.component.scss'
})
export class AppMenuComponent {

    public items: MenuItem[] = [
        { label: 'Home', icon: PrimeIcons.HOME},
        { label: 'Files', icon: PrimeIcons.FILE },
        { label: 'Videos', icon: PrimeIcons.VIDEO },
    ]

    public iconTheme = PrimeIcons.SUN;

    toggleTheme() {
        const element = document.querySelector('html');
        element!.classList.toggle('my-app-dark');

        this.iconTheme = this.iconTheme === PrimeIcons.SUN ? PrimeIcons.MOON : PrimeIcons.SUN;
    }
}
