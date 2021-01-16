import {Injectable} from'@angular/core'
import {HttpClient} from '@angular/common/http'
import {Subject} from 'rxjs'

@Injectable()
export class ApiService {


    constructor(private http:HttpClient){}

    private clickedQuestion = new Subject<any>();
	
    selectedQuestion = this.clickedQuestion.asObservable();
    
    private clickedQuiz = new Subject<any>();
	
	selectedQuiz = this.clickedQuiz.asObservable();


    clickQuestion(question: any) 
    {this.clickedQuestion.next(question)}
    

    clickQuiz(quiz: any) 
    {this.clickedQuiz.next(quiz)}


   


    PostQuestion(question){
        this.http.post('https://localhost:5001/api/questions',question).subscribe(res => {
            console.log(res)
        })
        console.log(question)

    }

    PostQuiz(quiz){
        this.http.post('https://localhost:5001/api/quizzes',quiz).subscribe(res => {
            console.log(res)
        })

    }

    GetQuestions(quizID){
        return this.http.get(`https://localhost:5001/api/questions/${quizID}`);
    }

    GetQuizzes(){
        return this.http.get('https://localhost:5001/api/quizzes');
    }


    PutQuestion(question){
        return this.http.put(`https://localhost:5001/api/questions/${question.id}`,question).subscribe(res => {
            console.log(res)
        });
    }

    PutQuiz(quiz: any){
        return this.http.put(`https://localhost:5001/api/quizzes/${quiz.id}`,quiz).subscribe(res => {
            console.log(res)
        });
    }

}

