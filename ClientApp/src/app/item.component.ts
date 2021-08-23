import { Component, Input, OnInit } from '@angular/core';

@Component({ 
    selector: '[item]',
    template: `
        <span *ngIf="data !== undefined; else empty">
            {{data.name}}
        </span>
        <span *ngIf="data === undefined; else empty">
            
        </span>
    `
})
export class Component{
    @Input() data: any;  
}