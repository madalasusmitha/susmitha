import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demoapp-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
  
  name:string="susmitha";
  class: string="it";
  age:number=12;

  constructor() { }

  ngOnInit() {
  }

}
