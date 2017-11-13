import { Claim, initialClaim } from './claim.model';
import { actions, EntityAction } from '../entity/entity.actions';
import { SliceAction } from '../slice/slice.actions';
import { Entities, initialEntities } from '../entity/entity.model';
import * as entityFunctions from '../entity/entity.functions';
import * as sliceFunctions from '../slice/slice.functions';
import { slices } from '../util';
import { typeFor } from '../util';

export function reducer(state = initialEntities<Claim>(slices.CLAIM, initialClaim),
    action: EntityAction<Claim>): Entities<Claim> {
    switch (action.type) {
        case typeFor(slices.CLAIM, actions.ADD_SUCCESS):
        case typeFor(slices.CLAIM, actions.ADD_TEMP):
            return entityFunctions.addEntityToStore<Claim>(state, <any>action);
        case typeFor(slices.CLAIM, actions.ASYNC_SUCCESS):
            return entityFunctions.addEntitiesToStore(state, <any>action);
        case typeFor(slices.CLAIM, actions.PATCH_EACH):
            return entityFunctions.patchEach<Claim>(state, <any>action);
        case typeFor(slices.CLAIM, actions.PATCH):
        case typeFor(slices.CLAIM, actions.UPDATE):
            return entityFunctions.update<Claim>(state, <any>action);
        default: {
            return state;
        }
    }
}

export const getEntities = (state: Entities<Claim>) => state.entities;

export const getIds = (state: Entities<Claim>) => state.ids;
