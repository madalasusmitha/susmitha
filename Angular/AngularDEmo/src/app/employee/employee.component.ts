import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent  {

  firstname:string="Susmitha";
  lastname:string="Madala";
  Email:string="sush@gmail.com";
  Age:number=21;
getstyle():void
{
let styles="font-style:italic,color:brown";
}
onclick()
{
  
}
}
