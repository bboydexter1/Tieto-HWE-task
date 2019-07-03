import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public currentNumber = 0;
  public nextNumber = 1;

  public fibonacciSequence() {
    var sumHolder = this.nextNumber + this.currentNumber;
    this.currentNumber = this.nextNumber;
    this.nextNumber = sumHolder;
  }
}
