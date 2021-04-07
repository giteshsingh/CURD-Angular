import { DepartmentService } from './../../Services/department.service';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-show-dep',
  templateUrl: './show-dep.component.html',
  styleUrls: ['./show-dep.component.css']
})
export class ShowDepComponent implements OnInit {

  constructor(private service:DepartmentService) { }
  DepartmentList: any = [];
  ModalTitle: string='';
  ActivateAddEditDepComp: boolean = false;
  dep: any;

  ngOnInit(): void {
    this.refreshDeptList();

  }

  addClick() {
    //console.log("add department clicked");
    this.dep = {
      departmentId: 0,
      departmentName:""
    }
    this.ModalTitle = "Add Department";
    this.ActivateAddEditDepComp = true;
    this.refreshDeptList();
  }

  editClick(item:any) {
    console.log(item);
    this.dep = item;
    this.ModalTitle = "Edit Department";
    this.ActivateAddEditDepComp = true;
  }

  deleteClick(item: any) {
    this.dep = item;
    console.log(this.dep.departmentId);
     if (confirm('are you sure?')){
       this.service.deleteDepartment(this.dep.departmentId).subscribe(data => {
         alert('record deleted');
         this.refreshDeptList();
       });
     } 
    
  }

  closeClick() {
    this.ActivateAddEditDepComp = false;
    this.refreshDeptList();
  }
  
  
 refreshDeptList() {
    this.service.getDepList().subscribe(data => {
      this.DepartmentList = data;
      
    })
 }
  
  
}
