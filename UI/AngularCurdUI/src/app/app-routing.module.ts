import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import {EmployeeComponent } from './employee/employee.component';
import { DepartmentComponent } from './department/department.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  { path: 'employee', component: EmployeeComponent },
  {path:'department',component:DepartmentComponent},
  
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    BrowserModule,
    RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
