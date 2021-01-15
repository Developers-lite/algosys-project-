import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { QuizDetail } from '../dto/QuizDetailDtos.dto';

@Injectable({
  providedIn: 'root'
})
export class QuizDetailApiService {

  constructor(private httpClient: HttpClient) {  }

  private routeGetAll = () => `api/QuizDetailApi`;
    public getAll(): Observable<QuizDetail[]> {
        const url = this.routeGetAll();
        return this.httpClient.get(url, undefined) as Observable<any>;
    }

    private routeGetById = (quizId: number) => `api/QuizDetailApi/${quizId}`;
    public getById(quizId: number): Observable<QuizDetail> {
        const url = this.routeGetById(quizId);
        return this.httpClient.get(url, undefined) as Observable<any>;
    }
}
