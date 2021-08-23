import { Component, Input, OnInit } from '@angular/core';

@Component({
    selector: '[list]',
    template: '<ul class="list-group"><li listItem *ngFor="let item of items" [data]="item" class="list-group-item" ></li></ul>'
})
export class ListComponent implements OnInit {
    @Input() api: string;

    items: any[];
    options: any;

    constructor() {
    }

    async ngOnInit() {
        this.options = await (await fetch(this.api, { method: 'OPTIONS' })).json();
        this.items = new Array(this.options.count);
        //this.items[0] = { name: "46 47 48", id: 47 };
        this.items = await (await fetch(this.api, { method: 'GET' })).json();
    }
}