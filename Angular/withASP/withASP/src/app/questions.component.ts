import { Component, OnInit } from '@angular/core';
import { ApiService } from './api.service';
import {Question} from './models'
import { ActivatedRoute } from '@angular/router';


@Component({
selector: "questions",
templateUrl: "questions.component.html"
})


export class QuestionsComponent implements OnInit {

questions:any;

constructor(public api: ApiService,private route: ActivatedRoute){}

ngOnInit() {
    this.api.GetQuestions(this.route.snapshot.paramMap.get('quizID')).subscribe(res => {
        this.questions = res})
    }

}