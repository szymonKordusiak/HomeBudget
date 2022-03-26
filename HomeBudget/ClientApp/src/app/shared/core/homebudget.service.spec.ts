import { TestBed } from '@angular/core/testing';

import { HomebudgetService } from './homebudget.service';

describe('HomebudgetService', () => {
  let service: HomebudgetService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HomebudgetService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
