﻿//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
//
using System;
using UnityEngine;

namespace HoloToolkit.Unity
{
    public struct RaycastResultHelper
    {
        public RaycastResultHelper(RaycastHit hit, LayerMask surface) : this(hit.collider, hit.point, hit.normal, hit.distance, hit.textureCoord, hit.textureCoord2, surface)
        {
        }

        public RaycastResultHelper(Collider collider, Vector3 point, Vector3 normal, float distance, Vector2 textureCoord, Vector2 textureCoord2, LayerMask surface)
        {
            layer = collider != null ? collider.gameObject.layer : LayerExtensions.Surface;

            if (layer == surface.value)
            {
                // Spoof the mirage raycast result of 'no collider' if we hit a unity SR layer.
                this.collider = null;
            }
            else
            {
                this.collider = collider;
            }

            this.point = point;
            this.normal = normal;
            this.distance = distance;
            transform = null;
            this.textureCoord = textureCoord;
            this.textureCoord2 = textureCoord2;
        }

        private Collider collider;
        public Collider Collider
        {
            get { return collider; }
            private set { collider = value; }
        }

        private int layer;
        public int Layer
        {
            get { return layer; }
            private set { layer = value; }
        }

        private Vector3 normal;
        public Vector3 Normal
        {
            get { return normal; }
            private set { normal = value; }
        }

        private float distance;
        public float Distance
        {
            get { return distance; }
            private set { distance = value; }
        }

        private Vector3 point;
        public Vector3 Point
        {
            get { return point; }
            private set { point = value; }
        }

        private Transform transform;
        public Transform Transform
        {
            get
            {
                if (transform == null &&
                    Collider != null)
                {
                    transform = Collider.transform;
                }

                return transform;
            }
        }

        private Vector2 textureCoord;
        public Vector2 TextureCoord
        {
            get { return textureCoord; }
            private set { textureCoord = value; }
        }

        private Vector2 textureCoord2;
        public Vector2 TextureCoord2
        {
            get { return textureCoord2; }
            private set { textureCoord2 = value; }
        }

        public Vector3 GetNormalFromTextureCoord()
        {
            // Assumes packed at unit length
            return new Vector3(textureCoord.x, textureCoord.y, 1f - Mathf.Sqrt(textureCoord.x * textureCoord.x + textureCoord.y * textureCoord.y));
        }
        public void OverrideNormalFromTextureCoord()
        {
            normal = GetNormalFromTextureCoord();
        }

        public void OverridePoint(Vector3 pos)
        {
            point = pos;
        }

        public override string ToString()
        {
            return string.Format(
                "Collider: {1}{0}Game object: {2}{0}Distance: {3}{0}Normal: {4}{0}Point: {5}{0}Texture coord: {6}{0}Texture coord 2: {7}",
                Environment.NewLine,
                Collider != null ? Collider.ToString() : "None",
                Collider != null ? Collider.gameObject.ToString() : "None",
                Distance,
                Normal,
                Point,
                TextureCoord,
                TextureCoord2);
        }

        public static readonly RaycastResultHelper None = default(RaycastResultHelper);
    }
}
