import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ICourseCategories } from './model-ts/CourseCategories';
import { Courses } from './model-ts/Courses';
import { Users } from './model-ts/Users';

@Injectable({
  providedIn: 'root'
})
export class MainServiceService {

  myAppUrl: string = "";

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.myAppUrl = baseUrl;
  }

  getCoursecategories(): Observable<ICourseCategories[]> {
    return this.http.get<ICourseCategories[]>(this.myAppUrl + 'api/CourseCategories');
  }

  getsubCategory(id: number): Observable<ICourseCategories[]> {
    return this.http.get<ICourseCategories[]>(this.myAppUrl + 'api/CourseCategories/api/getcoursebyid/' + id);
  }
  getCourse(id: number): Observable<ICourseCategories[]> {
    return this.http.get<ICourseCategories[]>(this.myAppUrl + 'api/CourseCategories/api/getcoursebyid/' + id);
  }
  getProgram(id: number): Observable<Courses[]> {
    return this.http.get<Courses[]>(this.myAppUrl + 'api/Courses/api/getcoursebyid/' + id);
  }

  getusers(id: number): Observable<Users[]> {
    return this.http.get<Users[]>(this.myAppUrl + 'api/Users/api/getuserbycourseid/' + id);
  }
}
