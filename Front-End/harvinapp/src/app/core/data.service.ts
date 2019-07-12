import { Employee } from './../employee';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { API_HR } from "../shared/constants/constants";

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private allEmployeeEndpoint: string = "api/Employee";

  constructor(private http: HttpClient) { }

  getAll() {
    return this.http.get<Employee[]>(`${API_HR.url}${this.allEmployeeEndpoint}`);
  }

  getById(id: number) {
    return this.http.get<Employee>(`${API_HR.url}${this.allEmployeeEndpoint}${id}`);
  }
}