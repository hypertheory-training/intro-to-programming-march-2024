import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-todo-entry',
  standalone: true,
  imports: [ReactiveFormsModule],
  template: `
    <form [formGroup]="form" (ngSubmit)="addItem()">
      <div>
        <label
          >Description
          <input
            type="text"
            formControlName="description"
            placeholder="Type here"
            class="input input-bordered w-full max-w-xs"
          />
        </label>
        <button type="submit" class="btn btn-primary">
          Add Item To The List
        </button>
      </div>
    </form>
  `,
  styles: ``,
})
export class TodoEntryComponent {
  form = new FormGroup({
    description: new FormControl(''),
  });

  addItem() {
    console.log(this.form.value);
  }
}
