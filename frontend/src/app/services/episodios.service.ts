import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';


export interface Informacion {
  count: number;
  pages: number;
  next: string;
  prev: string;
}

export interface Episodio {
  id: number;
  name: string;
  air_date: string;
  episode: string;
  characters: string[];
  url: string;
  created: string;
}


export interface ApiResponse {
  info: Informacion;
  results: Episodio[];
}


@Injectable({
  providedIn: 'root'
})
export class EpisodiosService {

  private apiUrl = `${environment.apiUrl}/episodio`;

  constructor(private http: HttpClient) { }

  obtenerEpisodios(page: number): Observable<ApiResponse> {
    return this.http.get<ApiResponse>(`${this.apiUrl}?page=${page}`);
  }
}
