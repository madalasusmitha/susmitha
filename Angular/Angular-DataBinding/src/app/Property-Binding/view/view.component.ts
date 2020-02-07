import { Component, OnInit } from '@angular/core';
import {Student} from'src/app/Models/student'

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {
item:Student

  constructor() { 
    this.item=new Student();
    this.item.sid=1;
    this.item.Age=21;
    this.item.sname='susmitha';
    this.item.std="it";
    this.item.Dob=new Date(2020,7,1);
  }

  ngOnInit() {
  }

}
