import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  urlImagen = "https://sg.com.mx/sites/default/files/styles/570x500/public/images/angular-logo.png?itok=_4hR0cNu"

  constructor() { }

  ngOnInit(): void {
  }

}
