import {Component, OnInit} from '@angular/core'
import {ApiService} from './api.service'
import { Question } from './models'
import { ActivatedRoute } from '@angular/router'

@Component ({
    selector: 'question',
    templateUrl: './question.component.html'

})
export class QuestionComponent implements OnInit {

    question: any = {}
    quizID

    constructor(private api: ApiService, private route: ActivatedRoute){}

    ngOnInit(){
        this.quizID = this.route.snapshot.paramMap.get('quizID')
        this.api.selectedQuestion.subscribe(question => { this.question = question})
    }


    post(question){
        this.question.quizID = Number(this.quizID)
        this.api.PostQuestion(question)
    }

    put(question){
        this.api.PutQuestion(question)
    }

}