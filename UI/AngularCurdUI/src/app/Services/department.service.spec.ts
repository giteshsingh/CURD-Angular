import {  HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { TestBed } from '@angular/core/testing';
import {HttpClient,HttpErrorResponse} from '@angular/common/http'
import { DepartmentService } from './department.service';

describe('DepartmentService', () => {
 let httpClient: HttpClient;
  let service: DepartmentService;
  let httTestingController: HttpTestingController;

  beforeEach(() => {
    TestBed.configureTestingModule({
            imports: [HttpClientTestingModule],
            providers: [DepartmentService]
    });
    httpClient = TestBed.get(HttpClient);
    service = TestBed.get(DepartmentService);
    httTestingController = TestBed.get(HttpTestingController);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
