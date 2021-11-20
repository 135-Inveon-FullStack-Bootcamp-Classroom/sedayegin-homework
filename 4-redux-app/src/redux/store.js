import { createStore, combineReducers, applyMiddleware } from "redux";
import thunk from "redux-thunk";
import { createLogger } from "redux-logger";
import DataReducer from "./counter/counter.reducer";

const logger = createLogger({
  timestamp: true
});

const Reducers = combineReducers({
  DataREDUCER: DataReducer
});

let middlewares = applyMiddleware(logger, thunk);

const store = createStore(Reducers, middlewares);

export default store;
