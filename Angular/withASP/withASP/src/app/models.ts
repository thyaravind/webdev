
export class Question{

    constructor (public question: string,public id: number,public quizID: number,public correctAnswer: string = '', public option1='',public option2="",public option3=""){}


}

export class Quiz{

    constructor (public title: string = '',public id: number){}


}