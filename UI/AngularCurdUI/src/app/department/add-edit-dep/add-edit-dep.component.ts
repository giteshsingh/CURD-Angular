import { Router, Routes } from '@angular/router';
import { DepartmentService } from './../../Services/department.service';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-edit-dep',
  templateUrl: './add-edit-dep.component.html',
  styleUrls: ['./add-edit-dep.component.css']
})
export class AddEditDepComponent implements OnInit {

  constructor(private service:DepartmentService,private router: Router) { }

  @Input() dep: any;                //this varidable is passed from show-dep component
  departmentId: number=0;
  departmentName: string = '';


  ngOnInit(): void {
    this.departmentName = this.dep.departmentName;
    this.departmentId = this.dep.departmentId;

    
    console.log("department id " + this.dep.departmentId);
    console.log("department name " + this.dep.departmentName);

  }


  addDepartment() {
    
    var val = {
      departmentId: this.dep.departmentId,
      departmentName: this.dep.departmentName
    };
    
    this.service.addDepartment(val).subscribe(data => {
         alert('record added');
         
       });
    
  }

  updateDepartment() {
 
    var val = {
                departmentId :this.dep.departmentId,
                departmentName: this.dep.departmentName
    }
    console.log(val);
    this.service.updateDepartment(val).subscribe(res => {
       alert('record updated');
    });
    
  }

}
