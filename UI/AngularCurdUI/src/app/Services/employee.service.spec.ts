import { TestBed } from '@angular/core/testing';

import { EmployeeService } from './employee.service';
import {  HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { RouterTestingModule } from '@angular/router/testing';
import {HttpClient,HttpErrorResponse} from '@angular/common/http'

describe('EmployeeService', () => {
  let service: EmployeeService;
  let http: HttpClient;
  let httTestingController: HttpTestingController;

beforeEach(() => {
    TestBed.configureTestingModule({
            imports: [RouterTestingModule, HttpClientTestingModule],
            providers: [EmployeeService]
    }).compileComponents();
    http = TestBed.get(HttpClient);
    service = TestBed.get(EmployeeService);
    httTestingController = TestBed.get(HttpTestingController);
  });



  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
