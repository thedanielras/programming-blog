import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Blogpost } from './Models/Blogpost';
import { catchError, map, tap } from 'rxjs/operators'

@Injectable({
  providedIn: 'root'
})
export class BlogpostService {
  blogPostApiUrl: string = "api/blogpost/";

  constructor(private httpClient: HttpClient) { }

  getBlogPosts(): Observable<Blogpost[]> {
    return this.httpClient.get<Blogpost[]>(this.blogPostApiUrl).pipe(
      catchError(this.handleError<Blogpost[]>(`getBlogPosts`, []))
    );
  }

   /**
   * Handle Http operation that failed.
   * Let the app continue.
   * @param operation - name of the operation that failed
   * @param result - optional value to return as the observable result
   */
    private handleError<T>(operation = 'operation', result?: T) {
      return (error: any): Observable<T> => {

        // TODO: send the error to remote logging infrastructure
        console.error(error); // log to console instead

        // TODO: better job of transforming error for user consumption
        //this.log(`${operation} failed: ${error.message}`);

        // Let the app keep running by returning an empty result.
        return of(result as T);
      };
    }

}
