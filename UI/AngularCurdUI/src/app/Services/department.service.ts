import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import {Observable} from 'rxjs'

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  readonly APIUrl = 'http://localhost:56457/api';


  constructor(private http: HttpClient) { }
  
  getDepList(): Observable<any[]>{
    return this.http.get<any>(this.APIUrl + '/department');
  }

  addDepartment(val: any) {
    return this.http.post(this.APIUrl + '/department', val);
  }

  
  updateDepartment(val: any) {
    return this.http.patch(this.APIUrl + '/department/'+val.departmentId, val);
  }

  
  deleteDepartment(val: any) {
    return this.http.delete(this.APIUrl + '/department/'+val, val);
  }
}
