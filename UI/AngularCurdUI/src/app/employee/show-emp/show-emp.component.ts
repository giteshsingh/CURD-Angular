import { EmployeeService } from './../../Services/employee.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-show-emp',
  templateUrl: './show-emp.component.html',
  styleUrls: ['./show-emp.component.css']
})
export class ShowEmpComponent implements OnInit {

  constructor(private service: EmployeeService) { }


  EmployeeList: any = [];

  ngOnInit(): void {
    this.refreshEmployeeList();
  }

  refreshEmployeeList() {
    this.service.getEmpList().subscribe(data => {
      this.EmployeeList = data;
    })
  }
}
