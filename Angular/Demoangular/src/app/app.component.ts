import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title:string = 'Demoangular';
  num:number=10;
  imagepath:string='assets/tom&jerry.jpg';
  name:string="Ram";
  getname() :string{
    return this.name;
  }

}
