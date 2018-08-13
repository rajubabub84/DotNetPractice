import {Component} from "@angular/core";

@Component({
    selector: 'my-app',
    template: `
              <my-employeelist></my-employeelist>
               
             `
})
export class AppComponent {
    name: string = "Tom";
}