import { createFeature, createReducer } from '@ngrx/store';
import { TodoEntity } from '../types';
import { EntityState, createEntityAdapter } from '@ngrx/entity';

export interface TodosState extends EntityState<TodoEntity> {}

const adapter = createEntityAdapter<TodoEntity>();
// const initialState: TodosState = adapter.getInitialState();
const initialState: TodosState = {
  ids: ['1', '2'],
  entities: {
    '1': { id: '1', description: 'Buy Beer' },
    2: { id: '2', description: 'Clean Garage' },
  },
};
export const todosFeature = createFeature({
  name: 'todos',
  reducer: createReducer(initialState),
});
