import { Component } from '@angular/core';
import { PageHeaderComponent } from './components/page-header/page-header.component';
import { DemoComponent } from './components/demo/demo.component';

@Component({
  selector: 'app-root',
  standalone: true,
  template: `
    <app-page-header />
    <main></main>
  `,
  styles: [],
  imports: [PageHeaderComponent, DemoComponent],
})
export class AppComponent {}
