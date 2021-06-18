import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import {RouterModule} from '@angular/router'
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http'
import {FormsModule, ReactiveFormsModule} from '@angular/forms'


//components and Services
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { QuestionComponent } from './question.component';
import { QuestionsComponent } from './questions.component';
import { HomeComponent } from './home.component';
import { NavComponent } from './nav.component';
import { QuizComponent } from './quiz/quiz.component';
import { QuizzesComponent } from './quiz/quizzes/quizzes.component';


import {ApiService} from './api.service'
import { AuthService } from './auth.service';


//Styling with Angular material
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';
import {MatInputModule} from '@angular/material/input';
import {MatCardModule} from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import {MatListModule} from '@angular/material/list';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatButtonModule} from '@angular/material/button';
import {MatSidenavModule} from '@angular/material/sidenav';
import { RegisterComponent } from './register/register.component';
import { AuthInterceptor } from './auth.interceptor';
import {LoginComponent} from './login/login.component';






const routes = [
  {path: 'question/:quizID', component: QuestionComponent},
  {path: 'questions/:quizID', component: QuestionsComponent},
  {path: '', component: HomeComponent},
  {path: 'quiz', component: QuizComponent},
  {path: 'quizzes', component: QuizzesComponent},
  {path: 'register', component: RegisterComponent},
  {path: 'login', component: LoginComponent}
]


@NgModule({
  declarations: [
    AppComponent,
    QuestionComponent,
    QuestionsComponent,
    HomeComponent,
    NavComponent,
    QuizComponent,
    QuizzesComponent,
    RegisterComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatSliderModule,
    MatInputModule,
    MatCardModule,
    MatListModule,
    MatFormFieldModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule.forRoot(routes)

  ],
  providers: [ApiService,AuthService, {provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor,multi: true}],
  bootstrap: [AppComponent],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class AppModule { }
