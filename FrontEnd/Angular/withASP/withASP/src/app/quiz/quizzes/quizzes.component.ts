import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/api.service';

@Component({
  selector: 'quizzes',
  templateUrl: './quizzes.component.html'

})
export class QuizzesComponent implements OnInit {

  quizzes

  constructor(public api: ApiService) { }

  ngOnInit(): void {
    this.api.GetQuizzes().subscribe(res => {
      this.quizzes = res})
  }

}
