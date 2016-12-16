import { Component, OnInit } from '@angular/core';

import { PageService } from '../shared/page.service';

@Component({
    moduleId: module.id,
    templateUrl: 'home.component.html'
})
export class HomeComponent implements OnInit {
    pages: string[];

    constructor(private pageService: PageService) { }

    ngOnInit() {
        this.pageService.getPages()
            .subscribe(pages => this.pages = pages);
    }
}