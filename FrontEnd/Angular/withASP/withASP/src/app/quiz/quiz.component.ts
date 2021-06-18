import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';
import { Quiz } from '../models';

@Component({
  selector: 'quiz',
  templateUrl: './quiz.component.html'
})
export class QuizComponent implements OnInit {

  quiz: any = {}

  constructor(private api : ApiService) { }

  ngOnInit(): void {
    this.api.selectedQuiz.subscribe(quiz => { this.quiz = quiz})
  }

  post(quiz){
    this.api.PostQuiz(quiz)
  }

  put(quiz){
    this.api.PutQuiz(quiz)
  }

}
