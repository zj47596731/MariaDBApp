import { Component } from '@angular/core';
import { MainServiceService } from './../main-service.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  public CourseCat = [];
  public SubCat = [];
  public Courses = [];
  public Programs = [];
  public CourseData = [];
  public UsersData = [];


  constructor(private myservice: MainServiceService) {
    this.getCourseCategories();
  }
  getCourseCategories() {
    return this.myservice.getCoursecategories().subscribe(
      data => this.CourseCat = data);
  }

  sub_catdropdown(value: number) {

    return this.myservice.getsubCategory(value).subscribe(
      data => this.SubCat = data);
  }

  coursedropdown(value: number) {
    return this.myservice.getCourse(value).subscribe(
      data => this.Courses = data);
  }
  programdropdown(value: number) {
    return this.myservice.getProgram(value).subscribe(
      data => this.Programs = data);
    
  }
  getUsersData(value: number) {
    return this.myservice.getusers(value).subscribe(
      data => this.UsersData = data);
  }
}
