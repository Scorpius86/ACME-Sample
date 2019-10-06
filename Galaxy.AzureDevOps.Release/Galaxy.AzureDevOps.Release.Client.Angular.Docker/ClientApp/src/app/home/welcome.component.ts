import { Component } from '@angular/core';

@Component({
  templateUrl: './welcome.component.html'
})
export class WelcomeComponent {
  public pageTitle = 'Welcome';
  public date = Date.now();
}
