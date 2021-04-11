import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs'


@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  readonly APIUrl = 'http://localhost:56457/api';


  constructor(private http: HttpClient) { }
  
  getEmpList(): Observable<any[]>{
    return this.http.get<any>(this.APIUrl + '/Employees');
  }

  addEmployee(val: any) {
    return this.http.post(this.APIUrl + '/Employees', val);
  }

  
  updateEmployee(val: any) {
    return this.http.patch(this.APIUrl + '/Employees', val);
  }

  
  deleteEmployee(val: any) {
    return this.http.delete(this.APIUrl + '/Employees', val);
  }
}
