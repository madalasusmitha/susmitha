import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee';

@Component({
  selector: 'app-democ',
  templateUrl: './democ.component.html',
  styleUrls: ['./democ.component.css']
})
export class DemocComponent implements OnInit {
  item:Employee

  constructor() { 
    //initialise employee
    this.item=new Employee();
  }

  ngOnInit() {
  }
  public Add()
  {
    
    console.log(this.item)
  }

}
