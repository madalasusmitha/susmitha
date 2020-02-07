import { Component, OnInit } from '@angular/core';
import {Student} from 'src/app/Models/student';
import{ViewCustomer} from 'src/app/Models/view-customer'

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {
  obj:ViewCustomer;

  constructor() {
    this.obj={Name:'susmitha',City:'chennai',Address:'mgr street',Email:'sush@gmail.com',Contact:9948232069};
   }

  ngOnInit() {
  }

}
