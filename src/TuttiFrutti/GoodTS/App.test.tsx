import { describe, it, expect } from 'vitest';

describe('General Test', () => {
    it('testA1', async () => {
        expect(true).toBe(true);
        expect(1).toBeGreaterThan(0);
    });
});

type generico<T> = T extends string ? "text" : never

type tes = generico<1>
