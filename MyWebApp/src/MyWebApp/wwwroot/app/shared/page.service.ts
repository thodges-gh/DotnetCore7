import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';

@Injectable()
export class PageService {
    
    constructor(private http: Http) { }

    getPages() {
        return this.http.get('controllers/pages')
            .map(response => <string[]>response.json());
    }
}