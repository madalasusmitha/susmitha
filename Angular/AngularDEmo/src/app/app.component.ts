import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AngularDEmo';
  customer:any[]=[{"name":'Raj',"country":'India',"age":21},
  {"name":'swathi',"country":'Us',"age":24},
  {"name":'sushmitha',"country":'China',"age":26},
]
}
